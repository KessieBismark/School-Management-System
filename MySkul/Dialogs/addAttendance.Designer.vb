<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAttendance
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtstaff_id = New System.Windows.Forms.TextBox()
        Me.txtstaff = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txtdays = New Telerik.WinControls.UI.RadTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.Panel3.Size = New System.Drawing.Size(531, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "ADD ATTENDANCE"
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
        Me.Label1.Location = New System.Drawing.Point(508, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.Controls.Add(Me.txtstaff_id)
        Me.Panel16.Controls.Add(Me.txtstaff)
        Me.Panel16.Controls.Add(Me.Label13)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txtdays)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(532, 112)
        Me.Panel16.TabIndex = 6
        '
        'txtstaff_id
        '
        Me.txtstaff_id.Location = New System.Drawing.Point(14, 5)
        Me.txtstaff_id.Name = "txtstaff_id"
        Me.txtstaff_id.Size = New System.Drawing.Size(100, 21)
        Me.txtstaff_id.TabIndex = 85
        Me.txtstaff_id.Visible = False
        '
        'txtstaff
        '
        Me.txtstaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
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
        Me.Label13.Location = New System.Drawing.Point(24, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 15)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Days Present :"
        '
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(442, 21)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 67
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txtdays
        '
        Me.txtdays.BackColor = System.Drawing.SystemColors.Control
        Me.txtdays.Location = New System.Drawing.Point(120, 65)
        Me.txtdays.Name = "txtdays"
        Me.txtdays.Size = New System.Drawing.Size(308, 36)
        Me.txtdays.TabIndex = 80
        Me.txtdays.ThemeName = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Staff Name :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(442, 69)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(78, 36)
        Me.cclear.TabIndex = 68
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
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
        Me.Panel1.Size = New System.Drawing.Size(533, 140)
        Me.Panel1.TabIndex = 4
        '
        'addAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 140)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addAttendance"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txtstaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtstaff As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label13 As Label
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtdays As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents txtstaff_id As TextBox
End Class
