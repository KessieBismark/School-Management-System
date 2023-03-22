<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dcheques
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chequegrid = New Telerik.WinControls.UI.RadGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtcid = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.chequegrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chequegrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.chequegrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 543)
        Me.Panel1.TabIndex = 0
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
        Me.Panel3.Size = New System.Drawing.Size(799, 24)
        Me.Panel3.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(72, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "DELETED CHEQUES "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(3, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Label19 -"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(776, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Location = New System.Drawing.Point(0, 26)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(801, 63)
        Me.Panel10.TabIndex = 11
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.LinkLabel4)
        Me.Panel11.Controls.Add(Me.RadTextBox4)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.RadButton6)
        Me.Panel11.Location = New System.Drawing.Point(3, 6)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(795, 50)
        Me.Panel11.TabIndex = 9
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(202, 24)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(62, 16)
        Me.LinkLabel4.TabIndex = 4
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Refresh"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox4.AutoSize = False
        Me.RadTextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadTextBox4.Location = New System.Drawing.Point(401, 9)
        Me.RadTextBox4.Multiline = True
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.Size = New System.Drawing.Size(319, 36)
        Me.RadTextBox4.TabIndex = 3
        Me.RadTextBox4.ThemeName = "Material"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search :"
        '
        'RadButton6
        '
        Me.RadButton6.BackColor = System.Drawing.Color.SteelBlue
        Me.RadButton6.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton6.ForeColor = System.Drawing.SystemColors.Control
        Me.RadButton6.Location = New System.Drawing.Point(8, 8)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(147, 36)
        Me.RadButton6.TabIndex = 0
        Me.RadButton6.Text = "Restore"
        Me.RadButton6.ThemeName = "Material"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chequegrid)
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 455)
        Me.Panel2.TabIndex = 12
        '
        'chequegrid
        '
        Me.chequegrid.Controls.Add(Me.DateTimePicker1)
        Me.chequegrid.Controls.Add(Me.txtcid)
        Me.chequegrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chequegrid.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.chequegrid.MasterTemplate.AllowAddNewRow = False
        Me.chequegrid.MasterTemplate.AllowColumnReorder = False
        Me.chequegrid.MasterTemplate.ShowFilteringRow = False
        Me.chequegrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.chequegrid.Name = "chequegrid"
        Me.chequegrid.ReadOnly = True
        Me.chequegrid.ShowGroupPanel = False
        Me.chequegrid.ShowGroupPanelScrollbars = False
        Me.chequegrid.Size = New System.Drawing.Size(801, 455)
        Me.chequegrid.TabIndex = 7
        Me.chequegrid.Text = "RadGridView1"
        Me.chequegrid.ThemeName = "Material"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Visible = False
        '
        'txtcid
        '
        Me.txtcid.Location = New System.Drawing.Point(335, 45)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(100, 20)
        Me.txtcid.TabIndex = 9
        Me.txtcid.Visible = False
        '
        'dcheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 543)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dcheques"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dcheques"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.chequegrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chequegrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.chequegrid.ResumeLayout(False)
        Me.chequegrid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chequegrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtcid As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
