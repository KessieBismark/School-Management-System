<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcharges
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtcid = New System.Windows.Forms.Label()
        Me.txtcclass = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txtcclist = New Telerik.WinControls.UI.RadTextBox()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.txtcname = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcamount = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Panel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txtcclass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcclist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcamount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 320)
        Me.Panel1.TabIndex = 1
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.Controls.Add(Me.txtcid)
        Me.Panel16.Controls.Add(Me.txtcclass)
        Me.Panel16.Controls.Add(Me.Label9)
        Me.Panel16.Controls.Add(Me.Label8)
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txtcclist)
        Me.Panel16.Controls.Add(Me.cdelete)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Controls.Add(Me.txtcname)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Controls.Add(Me.txtcamount)
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(431, 296)
        Me.Panel16.TabIndex = 6
        '
        'txtcid
        '
        Me.txtcid.AutoSize = True
        Me.txtcid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcid.Location = New System.Drawing.Point(108, 20)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(0, 16)
        Me.txtcid.TabIndex = 86
        '
        'txtcclass
        '
        Me.txtcclass.BackColor = System.Drawing.SystemColors.Control
        Me.txtcclass.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.txtcclass.Location = New System.Drawing.Point(96, 148)
        Me.txtcclass.Name = "txtcclass"
        Me.txtcclass.Size = New System.Drawing.Size(308, 36)
        Me.txtcclass.TabIndex = 84
        Me.txtcclass.ThemeName = "Material"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Charge ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Class list :"
        '
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(30, 235)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 67
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txtcclist
        '
        Me.txtcclist.BackColor = System.Drawing.SystemColors.Control
        Me.txtcclist.Location = New System.Drawing.Point(96, 192)
        Me.txtcclist.Name = "txtcclist"
        Me.txtcclist.ReadOnly = True
        Me.txtcclist.Size = New System.Drawing.Size(308, 36)
        Me.txtcclist.TabIndex = 80
        Me.txtcclist.ThemeName = "Material"
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(305, 235)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 69
        Me.cdelete.Text = "Delete"
        Me.cdelete.ThemeName = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Class :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(159, 235)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(95, 36)
        Me.cclear.TabIndex = 68
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
        '
        'txtcname
        '
        Me.txtcname.AutoSize = False
        Me.txtcname.BackColor = System.Drawing.SystemColors.Control
        Me.txtcname.Location = New System.Drawing.Point(94, 60)
        Me.txtcname.Name = "txtcname"
        Me.txtcname.Size = New System.Drawing.Size(310, 36)
        Me.txtcname.TabIndex = 65
        Me.txtcname.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Amount :"
        '
        'txtcamount
        '
        Me.txtcamount.AutoSize = False
        Me.txtcamount.BackColor = System.Drawing.SystemColors.Control
        Me.txtcamount.Location = New System.Drawing.Point(94, 104)
        Me.txtcamount.Name = "txtcamount"
        Me.txtcamount.Size = New System.Drawing.Size(310, 36)
        Me.txtcamount.TabIndex = 66
        Me.txtcamount.ThemeName = "Material"
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
        Me.Panel3.Size = New System.Drawing.Size(430, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD CHARGES"
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
        Me.Label1.Location = New System.Drawing.Point(407, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addcharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "addcharges"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addayear"
        Me.Panel1.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txtcclass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcclist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcamount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtcid As Label
    Friend WithEvents txtcclass As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtcclist As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtcname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcamount As Telerik.WinControls.UI.RadTextBox
End Class
