<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addincome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtstudent_id = New System.Windows.Forms.TextBox()
        Me.debt = New System.Windows.Forms.Label()
        Me.radioprint = New Telerik.WinControls.UI.RadRadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpaid = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttype = New Telerik.WinControls.UI.RadDropDownList()
        Me.txtstname = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtinid = New System.Windows.Forms.Label()
        Me.txtdes = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtamount = New Telerik.WinControls.UI.RadTextBox()
        Me.cmdclear = New Telerik.WinControls.UI.RadButton()
        Me.cmddelete = New Telerik.WinControls.UI.RadButton()
        Me.cmdadd = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblstid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.radioprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpaid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblstid)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtstudent_id)
        Me.Panel1.Controls.Add(Me.debt)
        Me.Panel1.Controls.Add(Me.radioprint)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtpaid)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txttype)
        Me.Panel1.Controls.Add(Me.txtstname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtinid)
        Me.Panel1.Controls.Add(Me.txtdes)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtamount)
        Me.Panel1.Controls.Add(Me.cmdclear)
        Me.Panel1.Controls.Add(Me.cmddelete)
        Me.Panel1.Controls.Add(Me.cmdadd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 337)
        Me.Panel1.TabIndex = 1
        '
        'txtstudent_id
        '
        Me.txtstudent_id.Location = New System.Drawing.Point(427, 303)
        Me.txtstudent_id.Name = "txtstudent_id"
        Me.txtstudent_id.Size = New System.Drawing.Size(38, 22)
        Me.txtstudent_id.TabIndex = 67
        Me.txtstudent_id.Visible = False
        '
        'debt
        '
        Me.debt.AutoSize = True
        Me.debt.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.debt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.debt.Location = New System.Drawing.Point(468, 40)
        Me.debt.Name = "debt"
        Me.debt.Size = New System.Drawing.Size(0, 16)
        Me.debt.TabIndex = 66
        '
        'radioprint
        '
        Me.radioprint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioprint.Location = New System.Drawing.Point(471, 89)
        Me.radioprint.Name = "radioprint"
        Me.radioprint.Size = New System.Drawing.Size(100, 21)
        Me.radioprint.TabIndex = 65
        Me.radioprint.Text = "Print Invoice"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Description :"
        '
        'txtpaid
        '
        Me.txtpaid.BackColor = System.Drawing.SystemColors.Control
        Me.txtpaid.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Father"
        RadListDataItem2.Text = "Mother"
        RadListDataItem3.Text = "Sibling"
        RadListDataItem4.Text = "Guardian"
        RadListDataItem5.Text = "Other"
        Me.txtpaid.Items.Add(RadListDataItem1)
        Me.txtpaid.Items.Add(RadListDataItem2)
        Me.txtpaid.Items.Add(RadListDataItem3)
        Me.txtpaid.Items.Add(RadListDataItem4)
        Me.txtpaid.Items.Add(RadListDataItem5)
        Me.txtpaid.Location = New System.Drawing.Point(87, 198)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(309, 36)
        Me.txtpaid.TabIndex = 63
        Me.txtpaid.ThemeName = "Material"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Paid by :"
        '
        'txttype
        '
        Me.txttype.BackColor = System.Drawing.SystemColors.Control
        Me.txttype.Location = New System.Drawing.Point(88, 116)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(309, 36)
        Me.txttype.TabIndex = 60
        Me.txttype.ThemeName = "Material"
        '
        'txtstname
        '
        Me.txtstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtstname.BackColor = System.Drawing.SystemColors.Control
        Me.txtstname.Location = New System.Drawing.Point(88, 74)
        Me.txtstname.Name = "txtstname"
        Me.txtstname.Size = New System.Drawing.Size(309, 37)
        Me.txtstname.TabIndex = 59
        Me.txtstname.ThemeName = "Material"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Amount :"
        '
        'txtinid
        '
        Me.txtinid.AutoSize = True
        Me.txtinid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinid.Location = New System.Drawing.Point(88, 42)
        Me.txtinid.Name = "txtinid"
        Me.txtinid.Size = New System.Drawing.Size(0, 18)
        Me.txtinid.TabIndex = 56
        '
        'txtdes
        '
        Me.txtdes.AutoSize = False
        Me.txtdes.BackColor = System.Drawing.SystemColors.Control
        Me.txtdes.Location = New System.Drawing.Point(87, 240)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(309, 75)
        Me.txtdes.TabIndex = 2
        Me.txtdes.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Type :"
        '
        'txtamount
        '
        Me.txtamount.AutoSize = False
        Me.txtamount.BackColor = System.Drawing.SystemColors.Control
        Me.txtamount.Location = New System.Drawing.Point(87, 158)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(310, 36)
        Me.txtamount.TabIndex = 1
        Me.txtamount.ThemeName = "Material"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdclear.Location = New System.Drawing.Point(471, 208)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(120, 36)
        Me.cmdclear.TabIndex = 4
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.ThemeName = "Material"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.IndianRed
        Me.cmddelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cmddelete.Location = New System.Drawing.Point(471, 275)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(120, 36)
        Me.cmddelete.TabIndex = 5
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.ThemeName = "Material"
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cmdadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdadd.Location = New System.Drawing.Point(471, 141)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(120, 36)
        Me.cmdadd.TabIndex = 3
        Me.cmdadd.Text = "Save"
        Me.cmdadd.ThemeName = "Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Student :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Income ID :"
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
        Me.Panel3.Size = New System.Drawing.Size(639, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD A PAYMENT"
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
        Me.Label1.Location = New System.Drawing.Point(616, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblstid
        '
        Me.lblstid.AutoSize = True
        Me.lblstid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstid.Location = New System.Drawing.Point(358, 40)
        Me.lblstid.Name = "lblstid"
        Me.lblstid.Size = New System.Drawing.Size(0, 18)
        Me.lblstid.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Student ID :"
        '
        'addincome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 337)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "addincome"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addcourse"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.radioprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpaid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmddelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmddelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmdadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtamount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpaid As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label8 As Label
    Friend WithEvents txttype As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txtstname As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label7 As Label
    Friend WithEvents txtinid As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents radioprint As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents debt As Label
    Friend WithEvents txtstudent_id As TextBox
    Friend WithEvents lblstid As Label
    Friend WithEvents Label5 As Label
End Class
