<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reset_account
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
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.txtsq = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstaffid = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txta = New Telerik.WinControls.UI.RadTextBox()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.txtnp = New Telerik.WinControls.UI.RadTextBox()
        Me.txtrp = New Telerik.WinControls.UI.RadTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        CType(Me.txtsq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsq
        '
        Me.txtsq.BackColor = System.Drawing.SystemColors.Control
        Me.txtsq.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Administrator"
        RadListDataItem2.Text = "Head Mastor/Mistress"
        RadListDataItem3.Text = "Head of Academics"
        RadListDataItem4.Text = "Assistant Academic"
        RadListDataItem5.Text = "Head of Finance"
        RadListDataItem6.Text = "Assistant Finance"
        RadListDataItem7.Text = "Teacher"
        RadListDataItem8.Text = "Head of Management"
        Me.txtsq.Items.Add(RadListDataItem1)
        Me.txtsq.Items.Add(RadListDataItem2)
        Me.txtsq.Items.Add(RadListDataItem3)
        Me.txtsq.Items.Add(RadListDataItem4)
        Me.txtsq.Items.Add(RadListDataItem5)
        Me.txtsq.Items.Add(RadListDataItem6)
        Me.txtsq.Items.Add(RadListDataItem7)
        Me.txtsq.Items.Add(RadListDataItem8)
        Me.txtsq.Location = New System.Drawing.Point(132, 142)
        Me.txtsq.Name = "txtsq"
        Me.txtsq.Size = New System.Drawing.Size(539, 36)
        Me.txtsq.TabIndex = 0
        Me.txtsq.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "New Password :"
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
        Me.Panel1.Size = New System.Drawing.Size(683, 326)
        Me.Panel1.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Controls.Add(Me.Label3)
        Me.Panel16.Controls.Add(Me.txtstaffid)
        Me.Panel16.Controls.Add(Me.txtsq)
        Me.Panel16.Controls.Add(Me.Label9)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txta)
        Me.Panel16.Controls.Add(Me.cdelete)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Controls.Add(Me.txtnp)
        Me.Panel16.Controls.Add(Me.txtrp)
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(682, 298)
        Me.Panel16.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Answer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Security Question :"
        '
        'txtstaffid
        '
        Me.txtstaffid.AutoSize = True
        Me.txtstaffid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstaffid.Location = New System.Drawing.Point(146, 20)
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(0, 16)
        Me.txtstaffid.TabIndex = 86
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
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(35, 247)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 5
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txta
        '
        Me.txta.BackColor = System.Drawing.SystemColors.Control
        Me.txta.Location = New System.Drawing.Point(132, 185)
        Me.txta.Name = "txta"
        Me.txta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txta.Size = New System.Drawing.Size(539, 36)
        Me.txta.TabIndex = 2
        Me.txta.ThemeName = "Material"
        Me.txta.UseSystemPasswordChar = True
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(572, 247)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 7
        Me.cdelete.Text = "Close"
        Me.cdelete.ThemeName = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Repeat Password :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(295, 247)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(95, 36)
        Me.cclear.TabIndex = 6
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
        '
        'txtnp
        '
        Me.txtnp.AutoSize = False
        Me.txtnp.BackColor = System.Drawing.SystemColors.Control
        Me.txtnp.Location = New System.Drawing.Point(133, 56)
        Me.txtnp.Name = "txtnp"
        Me.txtnp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtnp.Size = New System.Drawing.Size(539, 36)
        Me.txtnp.TabIndex = 1
        Me.txtnp.ThemeName = "Material"
        Me.txtnp.UseSystemPasswordChar = True
        '
        'txtrp
        '
        Me.txtrp.AutoSize = False
        Me.txtrp.BackColor = System.Drawing.SystemColors.Control
        Me.txtrp.Location = New System.Drawing.Point(133, 99)
        Me.txtrp.Name = "txtrp"
        Me.txtrp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtrp.Size = New System.Drawing.Size(539, 36)
        Me.txtrp.TabIndex = 1
        Me.txtrp.ThemeName = "Material"
        Me.txtrp.UseSystemPasswordChar = True
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
        Me.Panel3.Size = New System.Drawing.Size(681, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(113, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "SET PASSWORD"
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
        Me.Label1.Location = New System.Drawing.Point(658, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'reset_account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 326)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "reset_account"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reset_account"
        CType(Me.txtsq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsq As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtstaffid As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txta As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtrp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnp As Telerik.WinControls.UI.RadTextBox
End Class
