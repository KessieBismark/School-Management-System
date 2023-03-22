<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsalaries
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthours = New Telerik.WinControls.UI.RadTextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.txtstaff = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txtamount = New Telerik.WinControls.UI.RadTextBox()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txthours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(461, 237)
        Me.Panel1.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Controls.Add(Me.txthours)
        Me.Panel16.Controls.Add(Me.Txtid)
        Me.Panel16.Controls.Add(Me.txtstaff)
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txtamount)
        Me.Panel16.Controls.Add(Me.cdelete)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(460, 213)
        Me.Panel16.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Working Hours :"
        '
        'txthours
        '
        Me.txthours.BackColor = System.Drawing.SystemColors.Control
        Me.txthours.Location = New System.Drawing.Point(120, 107)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(308, 36)
        Me.txthours.TabIndex = 86
        Me.txthours.ThemeName = "Material"
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(12, 3)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(77, 22)
        Me.Txtid.TabIndex = 85
        Me.Txtid.Visible = False
        '
        'txtstaff
        '
        Me.txtstaff.BackColor = System.Drawing.SystemColors.Control
        Me.txtstaff.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.txtstaff.Location = New System.Drawing.Point(120, 21)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.Size = New System.Drawing.Size(308, 36)
        Me.txtstaff.TabIndex = 84
        Me.txtstaff.ThemeName = "Material"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 16)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Salary :"
        '
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(33, 165)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 67
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txtamount
        '
        Me.txtamount.BackColor = System.Drawing.SystemColors.Control
        Me.txtamount.Location = New System.Drawing.Point(120, 65)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(308, 36)
        Me.txtamount.TabIndex = 80
        Me.txtamount.ThemeName = "Material"
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(330, 165)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 69
        Me.cdelete.Text = "Delete"
        Me.cdelete.ThemeName = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Staff Name :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(173, 165)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(95, 36)
        Me.cclear.TabIndex = 68
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
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
        Me.Panel3.Size = New System.Drawing.Size(459, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD/EDITH SALARY"
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
        Me.Label1.Location = New System.Drawing.Point(436, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addsalaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 237)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "addsalaries"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addsalaries"
        Me.Panel1.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txthours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Txtid As TextBox
    Friend WithEvents txtstaff As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label13 As Label
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtamount As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents txthours As Telerik.WinControls.UI.RadTextBox
End Class
