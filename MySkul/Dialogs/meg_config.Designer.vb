<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meg_config
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txturl = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cclear = New Telerik.WinControls.UI.RadButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cdelete = New Telerik.WinControls.UI.RadButton()
        Me.txtmh = New Telerik.WinControls.UI.RadTextBox()
        Me.cadd = New Telerik.WinControls.UI.RadButton()
        Me.txtapi = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.txturl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Size = New System.Drawing.Size(632, 24)
        Me.Panel3.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(609, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
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
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(183, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "MESSAGE CONFIGURATION"
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel16.Controls.Add(Me.Label2)
        Me.Panel16.Controls.Add(Me.txtapi)
        Me.Panel16.Controls.Add(Me.cadd)
        Me.Panel16.Controls.Add(Me.txtmh)
        Me.Panel16.Controls.Add(Me.cdelete)
        Me.Panel16.Controls.Add(Me.Label10)
        Me.Panel16.Controls.Add(Me.cclear)
        Me.Panel16.Controls.Add(Me.Label6)
        Me.Panel16.Controls.Add(Me.txturl)
        Me.Panel16.Location = New System.Drawing.Point(0, 23)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(633, 200)
        Me.Panel16.TabIndex = 6
        '
        'txturl
        '
        Me.txturl.AutoSize = False
        Me.txturl.BackColor = System.Drawing.SystemColors.Control
        Me.txturl.Location = New System.Drawing.Point(128, 60)
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(490, 36)
        Me.txturl.TabIndex = 1
        Me.txturl.ThemeName = "Material"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Message URL :"
        '
        'cclear
        '
        Me.cclear.BackColor = System.Drawing.SystemColors.Control
        Me.cclear.Location = New System.Drawing.Point(284, 149)
        Me.cclear.Name = "cclear"
        Me.cclear.Size = New System.Drawing.Size(95, 36)
        Me.cclear.TabIndex = 6
        Me.cclear.Text = "Clear"
        Me.cclear.ThemeName = "Material"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Message Header :"
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.IndianRed
        Me.cdelete.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.SystemColors.Control
        Me.cdelete.Location = New System.Drawing.Point(443, 149)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(98, 36)
        Me.cdelete.TabIndex = 7
        Me.cdelete.Text = "Close"
        Me.cdelete.ThemeName = "Material"
        '
        'txtmh
        '
        Me.txtmh.BackColor = System.Drawing.SystemColors.Control
        Me.txtmh.Location = New System.Drawing.Point(128, 107)
        Me.txtmh.Name = "txtmh"
        Me.txtmh.Size = New System.Drawing.Size(490, 36)
        Me.txtmh.TabIndex = 2
        Me.txtmh.ThemeName = "Material"
        '
        'cadd
        '
        Me.cadd.BackColor = System.Drawing.Color.SteelBlue
        Me.cadd.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cadd.ForeColor = System.Drawing.SystemColors.Control
        Me.cadd.Location = New System.Drawing.Point(142, 149)
        Me.cadd.Name = "cadd"
        Me.cadd.Size = New System.Drawing.Size(78, 36)
        Me.cadd.TabIndex = 5
        Me.cadd.Text = "Save"
        Me.cadd.ThemeName = "Material"
        '
        'txtapi
        '
        Me.txtapi.AutoSize = False
        Me.txtapi.BackColor = System.Drawing.SystemColors.Control
        Me.txtapi.Location = New System.Drawing.Point(128, 17)
        Me.txtapi.Name = "txtapi"
        Me.txtapi.Size = New System.Drawing.Size(490, 36)
        Me.txtapi.TabIndex = 89
        Me.txtapi.ThemeName = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "API Key :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel16)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 335)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.RadButton1)
        Me.Panel2.Location = New System.Drawing.Point(3, 229)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 98)
        Me.Panel2.TabIndex = 7
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadButton1.Location = New System.Drawing.Point(19, 32)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(196, 36)
        Me.RadButton1.TabIndex = 6
        Me.RadButton1.Text = "Check Connection"
        Me.RadButton1.ThemeName = "Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'meg_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 335)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "meg_config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "meg_config"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.txturl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cclear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents MaterialTheme1 As Telerik.WinControls.Themes.MaterialTheme
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtapi As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cadd As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtmh As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cdelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cclear As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txturl As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
End Class
