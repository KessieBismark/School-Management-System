<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.Label()
        Me.txtname = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txtcpword = New Telerik.WinControls.UI.RadTextBox()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.txtpword = New Telerik.WinControls.UI.RadTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuname = New Telerik.WinControls.UI.RadTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfl = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcpword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'txtstaffid
        '
        Me.txtstaffid.AutoSize = True
        Me.txtstaffid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffid.Location = New System.Drawing.Point(132, 20)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(0, 16)
        Me.txtstaffid.TabIndex = 86
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.Control
        Me.txtname.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.txtname.Location = New System.Drawing.Point(132, 52)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(400, 36)
        Me.txtname.TabIndex = 0
        Me.txtname.ThemeName = "Material"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Staff ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Name :"
        '
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(32, 285)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 5
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txtcpword
        '
        Me.txtcpword.BackColor = System.Drawing.SystemColors.Control
        Me.txtcpword.Location = New System.Drawing.Point(129, 184)
        Me.txtcpword.Name = "txtcpword"
        Me.txtcpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtcpword.Size = New System.Drawing.Size(403, 36)
        Me.txtcpword.TabIndex = 2
        Me.txtcpword.ThemeName = "Material"
        Me.txtcpword.UseSystemPasswordChar = True
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(333, 285)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 7
        Me.cdelete.Text = "Close"
        Me.cdelete.ThemeName = "Material"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD USER"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(564, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Repeat Password :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(174, 285)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(95, 36)
        Me.cclear.TabIndex = 6
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
        '
        'txtpword
        '
        Me.txtpword.AutoSize = False
        Me.txtpword.BackColor = System.Drawing.SystemColors.Control
        Me.txtpword.Location = New System.Drawing.Point(129, 137)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpword.Size = New System.Drawing.Size(403, 36)
        Me.txtpword.TabIndex = 1
        Me.txtpword.ThemeName = "Material"
        Me.txtpword.UseSystemPasswordChar = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 358)
        Me.Panel1.TabIndex = 2
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Controls.Add(Me.txtuname)
        Me.Panel16.Controls.Add(Me.LinkLabel1)
        Me.Panel16.Controls.Add(Me.Label3)
        Me.Panel16.Controls.Add(Me.txtstaffid)
        Me.Panel16.Controls.Add(Me.txtfl)
        Me.Panel16.Controls.Add(Me.txtname)
        Me.Panel16.Controls.Add(Me.Label9)
        Me.Panel16.Controls.Add(Me.Label8)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txtcpword)
        Me.Panel16.Controls.Add(Me.cdelete)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Controls.Add(Me.txtpword)
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(565, 330)
        Me.Panel16.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Username :"
        '
        'txtuname
        '
        Me.txtuname.AutoSize = False
        Me.txtuname.BackColor = System.Drawing.SystemColors.Control
        Me.txtuname.Location = New System.Drawing.Point(132, 94)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(400, 36)
        Me.txtuname.TabIndex = 89
        Me.txtuname.ThemeName = "Material"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(479, 296)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 16)
        Me.LinkLabel1.TabIndex = 88
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Function Limit :"
        '
        'txtfl
        '
        Me.txtfl.BackColor = System.Drawing.SystemColors.Control
        Me.txtfl.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Administrator"
        RadListDataItem2.Text = "Head Mastor/Mistress"
        RadListDataItem3.Text = "Head of Academics"
        RadListDataItem4.Text = "Assistant Academics"
        RadListDataItem5.Text = "Head of Finance"
        RadListDataItem6.Text = "Teacher"
        Me.txtfl.Items.Add(RadListDataItem1)
        Me.txtfl.Items.Add(RadListDataItem2)
        Me.txtfl.Items.Add(RadListDataItem3)
        Me.txtfl.Items.Add(RadListDataItem4)
        Me.txtfl.Items.Add(RadListDataItem5)
        Me.txtfl.Items.Add(RadListDataItem6)
        Me.txtfl.Location = New System.Drawing.Point(129, 229)
        Me.txtfl.Name = "txtfl"
        Me.txtfl.Size = New System.Drawing.Size(403, 36)
        Me.txtfl.TabIndex = 0
        Me.txtfl.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Password :"
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 358)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "users"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "users"
        CType(Me.txtname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcpword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txtuname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstaffid As Label
    Friend WithEvents txtname As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtcpword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtpword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfl As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuname As Telerik.WinControls.UI.RadTextBox
End Class
