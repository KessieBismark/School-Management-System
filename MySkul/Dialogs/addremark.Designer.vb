<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addremark
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblstudent_id = New System.Windows.Forms.Label()
        Me.txtremark = New Telerik.WinControls.UI.RadDropDownList()
        Me.lblstinfo = New System.Windows.Forms.Label()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTheme1 = New Telerik.WinControls.Themes.MaterialTheme()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtatt = New Telerik.WinControls.UI.RadTextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtremark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtatt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtatt)
        Me.GroupBox2.Controls.Add(Me.lblstudent_id)
        Me.GroupBox2.Controls.Add(Me.txtremark)
        Me.GroupBox2.Controls.Add(Me.lblstinfo)
        Me.GroupBox2.Controls.Add(Me.RadButton2)
        Me.GroupBox2.Controls.Add(Me.RadButton3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 220)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Remark"
        '
        'lblstudent_id
        '
        Me.lblstudent_id.AutoSize = True
        Me.lblstudent_id.Location = New System.Drawing.Point(27, 175)
        Me.lblstudent_id.Name = "lblstudent_id"
        Me.lblstudent_id.Size = New System.Drawing.Size(0, 16)
        Me.lblstudent_id.TabIndex = 63
        Me.lblstudent_id.Visible = False
        '
        'txtremark
        '
        Me.txtremark.BackColor = System.Drawing.SystemColors.Control
        Me.txtremark.Location = New System.Drawing.Point(115, 19)
        Me.txtremark.Name = "txtremark"
        Me.txtremark.Size = New System.Drawing.Size(489, 36)
        Me.txtremark.TabIndex = 62
        Me.txtremark.ThemeName = "Material"
        '
        'lblstinfo
        '
        Me.lblstinfo.Location = New System.Drawing.Point(13, 100)
        Me.lblstinfo.Name = "lblstinfo"
        Me.lblstinfo.Size = New System.Drawing.Size(591, 61)
        Me.lblstinfo.TabIndex = 8
        Me.lblstinfo.Text = "School ID :"
        '
        'RadButton2
        '
        Me.RadButton2.BackColor = System.Drawing.Color.SteelBlue
        Me.RadButton2.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.RadButton2.Location = New System.Drawing.Point(125, 164)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(120, 36)
        Me.RadButton2.TabIndex = 47
        Me.RadButton2.Text = "Save"
        Me.RadButton2.ThemeName = "Material"
        '
        'RadButton3
        '
        Me.RadButton3.BackColor = System.Drawing.SystemColors.Control
        Me.RadButton3.Location = New System.Drawing.Point(365, 164)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(120, 36)
        Me.RadButton3.TabIndex = 49
        Me.RadButton3.Text = "Clear"
        Me.RadButton3.ThemeName = "Material"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(95, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 18)
        Me.Label11.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Remark :"
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
        Me.Panel3.Size = New System.Drawing.Size(640, 24)
        Me.Panel3.TabIndex = 78
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(127, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "STUDENT REMARK"
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
        Me.Label1.Location = New System.Drawing.Point(617, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Attendance :"
        '
        'txtatt
        '
        Me.txtatt.AutoSize = False
        Me.txtatt.BackColor = System.Drawing.SystemColors.Control
        Me.txtatt.Location = New System.Drawing.Point(115, 61)
        Me.txtatt.Name = "txtatt"
        Me.txtatt.Size = New System.Drawing.Size(489, 36)
        Me.txtatt.TabIndex = 64
        Me.txtatt.ThemeName = "Material"
        '
        'addremark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(640, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addremark"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addremark"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtremark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtatt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblstinfo As Label
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents txtremark As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lblstudent_id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtatt As Telerik.WinControls.UI.RadTextBox
End Class
